import { Routes, Route } from 'react-router-dom';
import './App.css';
import Product from './pages/Product';
import LoginDeshboard from './components/login/LoginDeshboard';
import About from './pages/About';
import Protected from './pages/Protected';
import BackOffice from './pages/BackOffice';
import ProductList from './components/BackOfficeList';
import ProductForm from './components/BackOfficeForm';
import FooterCom from './components/footer/FooterCom';
import Favorites from './pages/Favorites';
import LoginTransition from './components/login/LoginTransition';
import useProducts from './hooks/useProducts';
import { useEffect } from 'react';
import { fetchUser } from './utils/api';
import { useDispatch, useSelector } from 'react-redux';
import { setUser } from './features/user-slice';
import ErrorBoundary from './errors/ErrorBoundary ';
import ErrorPage from './pages/ErrorPage';
import LoginControle from './components/login/LoginControle';
import ProtectedAdmin from './components/ProtectedAdmin';
import AlreadyLogged from './components/AlreadyLogged';
import Cart from './pages/Cart';
import { RootState } from './store/store';
import RegistrationForm from './components/login/RegisterForm';
import ProductDetails from './pages/ProductDetails';
import NavBarTop from './components/nav/NavBarTop';


function App() {
  const isDark = useSelector<RootState, boolean>((state)=> state.theme.isDark);
  const dispatch = useDispatch()

  useProducts();

  useEffect(() => {
    const token = localStorage.getItem("mywebsite_token");
    if (token) {
      fetchUser()
        .then(user => {
          dispatch(setUser(user));
        })
        .catch(e => {
          console.error("Error fetching user:", e);
          localStorage.removeItem('mywebsite_token');
        });
    }
  }, [dispatch]);
  
  return (<>
    <div className={!isDark ? 'on' : 'off'} >
      <ErrorBoundary>
        <NavBarTop/>
    
        <Routes>
          <Route path="/" element={<Product />} errorElement={<ErrorPage />} />
          <Route path="/loginDeshboard" element={<AlreadyLogged><LoginDeshboard /></AlreadyLogged>} errorElement={<ErrorPage />} />
          <Route path="/login" element={<AlreadyLogged><LoginControle /></AlreadyLogged>} errorElement={<ErrorPage />} />
          <Route path="/registerFrom" element={<AlreadyLogged><RegistrationForm /></AlreadyLogged>} errorElement={<ErrorPage />} />

          <Route path="/backoffice" element={<ProtectedAdmin><BackOffice /></ProtectedAdmin>} errorElement={<ErrorPage />}>
            <Route path="products" element={<ProductList />} errorElement={<ErrorPage />} />
            <Route path="products/new" element={<ProductForm />} errorElement={<ErrorPage />} />
            <Route path="products/edit/:id" element={<ProductForm />} errorElement={<ErrorPage />} />
          </Route>

          <Route path="/login_transition" element={<LoginTransition />} errorElement={<ErrorPage />} />

          <Route path="/products/" element={<Product />} errorElement={<ErrorPage />} />
          <Route path="/products/:gender/:category/:subcategory" element={<Product />} errorElement={<ErrorPage />} />
          <Route path="/products/:id" element={<ProductDetails/>} errorElement={<ErrorPage />} />
          <Route path="/favorites" element={<Protected><Favorites /></Protected>} errorElement={<ErrorPage />} />
          <Route path="/cart/" element={<Cart />} errorElement={<ErrorPage />} />
          <Route path="/about" element={<About />} errorElement={<ErrorPage />} />

        </Routes>
        <FooterCom />
      </ErrorBoundary>
    </div>
  </>
  );
}

export default App;
