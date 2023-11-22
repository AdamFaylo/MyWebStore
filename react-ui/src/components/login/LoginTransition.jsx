import { Navigate, useLocation, useNavigate } from "react-router-dom"
import { useEffect,useState } from 'react'

import api, { fetchUser } from "../../utils/api";
import { useDispatch } from "react-redux";
import { setUser } from "../../features/user-slice";

export default function LoginTransition() {
    const nav = useNavigate()
    const dispatch = useDispatch()
    const [token, setToken] = useState(localStorage.getItem("mywebsite_token"))
    useEffect(() => {
        if(!token) {
            nav('/')
            return;
        }
       
        fetchUser().then(user => {
            // dispatch the user into the redux
            // also do this in the App it self
            // if there is a token in the localStorage
            // do the action we did here and store the user object in redux
            dispatch(setUser(user))
            
            const isAdmin = user.type === 999
            if(isAdmin) {
                nav("/backoffice")
            }else {
                alert("Not admin, but hello " + user.serName)
                nav("/favorites")
            }
        }).catch(e => {
            alert(e.message)
            nav('/')
        })
    },[token])


    return <div>
        Loading...
    </div>
}