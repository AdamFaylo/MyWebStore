import { Routes, Route } from 'react-router-dom';
import './App.css';
import LoginDeshboard from './components/login/LoginDeshboard';
import About from './pages/About';
import Protected from './pages/Protected';
import BackOffice from './pages/BackOffice';
import ProductList from './components/backoffice/BackOfficeList';
import BackOfficeForm from './components/backoffice/BackOfficeForm';
import LoginTransition from './components/login/LoginTransition';
import useProducts from './hooks/useProducts';
import { useEffect } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import { me } from './features/user-slice';
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
import Home from './pages/Home';
import FooterComponent from './components/footer/FooterComponent';


function App() {
  const isDark = useSelector<RootState, boolean>((state) => state.theme.isDark);
  const dispatch = useDispatch()

  useProducts();

  useEffect(() => {
    const token = localStorage.getItem("mywebsite_token");
    if (token) {
      dispatch(me() as any)
    }
  }, [dispatch]);

  return (<>
    <div className={!isDark ? 'on' : 'off'} >
      <ErrorBoundary>
        <NavBarTop />
        <Routes>
   
          <Route path="/" element={<Home />} errorElement={<ErrorPage />} />
          <Route path="/login" element={<AlreadyLogged><LoginControle /></AlreadyLogged>} errorElement={<ErrorPage />} />
          <Route path="/registerFrom" element={<AlreadyLogged><RegistrationForm /></AlreadyLogged>} errorElement={<ErrorPage />} />

          <Route path="/backoffice" element={<ProtectedAdmin><BackOffice /></ProtectedAdmin>}>
            <Route path="/backoffice/products" element={<ProductList />} />
            <Route path="/backoffice/products/new" element={<BackOfficeForm />} />
            <Route path="/backoffice/products/edit/:id" element={<BackOfficeForm />} />
          </Route>

          <Route path="/login_transition" element={<LoginTransition />} errorElement={<ErrorPage />} />
          <Route path="/products/" element={<Home />} errorElement={<ErrorPage />} />
          <Route path="/products/:gender/:category/:subcategory" element={<Home />} errorElement={<ErrorPage />} />
          <Route path="/products/:id" element={<ProductDetails />} errorElement={<ErrorPage />} />

          <Route path="/cart" element={<Cart />} errorElement={<ErrorPage />} />
          <Route path="/about" element={<About />} errorElement={<ErrorPage />} />
          <Route path="/*" element={<ErrorPage />} errorElement={<ErrorPage />} />

        </Routes>
        <FooterComponent />
      </ErrorBoundary>
    </div>
  </>
  );
}

export default App;
