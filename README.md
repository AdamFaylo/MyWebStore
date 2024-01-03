# AdamFaylo
> A React project with a .NET backend.

## Table of Contents
* [General Information](#general-information)
* [Built With](#built-with)
* [How It Works](#how-it-works)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)

## ℹ️ General Information
<a name="general-information"/>

MyStore is a clothing store project. It is designed to solve [specific problems] and serves the purpose of [its intended use].
The project was created as a project task for [ReactJS]


## ⚒️ Built With
<a name="built-with"/>

### The following NuGet packages are used in the backend project:

- Microsoft.AspNetCore.Authentication.JwtB: 6.0.20
- Microsoft.AspNetCore.Identity.EntityFramewor: 6.0.21
- Microsoft.AspNetCore.Mvc.NewtonsoftJson: 6.0.20
- Microsoft.AspNetCore.Mvc.Versioning: 6.0.21
- Microsoft.EntityFrameworkCore: 7.0.9
- Microsoft.EntityFrameworkCore: 7.0.9


### The following packages are used in the frontend project: 
- @fontsource/roboto": "^5.0.8,
- @emotion/css": "^11.11.2,
- @emotion/react": "^11.11.1,
- @emotion/styled": "^11.11.0,
- @mantine/carousel": "^6.0.20,
- @mantine/core": "^6.0.20,
- @mantine/dates": "^6.0.20,
- @mantine/dropzone": "^6.0.20,
- @mantine/form": "^6.0.20,
- @mantine/hooks": "^6.0.20,
- @mantine/modals": "^6.0.20,
- @mantine/notifications": "^6.0.20,
- @mantine/nprogress": "^6.0.20,
- @mantine/prism": "^6.0.20,
- @mantine/spotlight": "^6.0.20,
- @mantine/tiptap": "^6.0.20,
- @mui/material": "^5.14.18,
- @reduxjs/toolkit": "^1.9.5,
- @tabler/icons": "^2.30.0,
- @tabler/icons-react": "^2.41.0,
- @testing-library/jest-dom": "^5.17.0,
- @testing-library/react": "^13.4.0,
- @testing-library/user-event": "^13.5.0,
- @tiptap/extension-link": "^2.1.8,
- @tiptap/react": "^2.1.8,
- @tiptap/starter-kit": "^2.1.8,
- @types/jest": "^27.5.2,
- @types/node": "^16.18.39,
- @types/react": "^18.2.18,
- @types/react-dom": "^18.2.7,
- "antd": "^5.8.6",
- "axios": "^1.4.0",
- "bootstrap": "^5.3.1",
- "react-bootstrap": "^2.8.0",
- "react": "^18.2.0",
- "react-dom": "^18.2.0",
- "react-icons": "^4.10.1",
- "react-loader-spinner": "^5.3.4",
- "react-redux": "^8.1.2",
- "react-router-dom": "^6.21.1",
- "react-scripts": "5.0.1",
- "react-toastify": "^9.1.3",
- "redux": "^4.2.1",
- "redux-logger": "^3.0.6",
- "sweetalert2": "^11.7.20",
- "typescript": "^4.9.5",
- "web-vitals": "^2.1.4",
- "yup": "^1.3.2"

## 💁 How It Works
<a name="how-it-works"/>

### Logged-In Admin:
Permission exists for Backoffice,\
Ability to dive into all products while being able to: add, extend and delete,\
Another option is to make a purchase on the website.

  ``` 
  Admin@gmail.com
  ```
  ``` 
  12345678
  ```
  

### Logged-In Users:
limited abilities,\
User action You can choose and the product is sent to the shopping cart,\

  ``` 
  User@gmail.com
  ```
  ``` 
  87654321
  ```


### It is very important to note:
- there is an ability to send the product to the shopping cart only with logged in or registered.


## 🔨 Features
<a name="features"/>

- CRUD operations for listings
- Ability to extend, delete and create a new product on the part of the customer
- Ability to change price from large to small or reverse
- Product selection by the plus and sent to the shopping cart
- Option to click on a product and dive into the diddles
- Dark/Light theme
- Responsive design
- Client-side validations
- Client-side search
- Client-side pagination
- JWT authentication
  
  
## 📷 Screenshots
<a name="screenshots"/>

<img width="806" alt="image" src="https://github.com/AdamFaylo/MyWebStore/assets/112155899/da137339-385e-4a14-892e-61cf5db6bb4f">
<img width="951" alt="image" src="https://github.com/AdamFaylo/MyWebStore/assets/112155899/91cc5675-90e1-4f04-b153-b389c79c7726">
<img width="952" alt="image" src="https://github.com/AdamFaylo/MyWebStore/assets/112155899/51d272bf-8cdc-46cf-87fe-8af4e0cbe206">
<img width="950" alt="image" src="https://github.com/AdamFaylo/MyWebStore/assets/112155899/5e1ad033-9d6c-4705-8da6-42f0347aaa7b">

## ⚙️ Setup
<a name="setup"/>

3. **Run Backend:**
   1. Open the solution in Visual Studio or your preferred IDE.
   2. Build and run the solution.
   3. Now when the database was created with your connection string we will need to manually apply the migrations.
   4. Open a terminal in the *api-server* folder and run the following command:
    ```Powershell
    dotnet ef database update
    ```
   5. You are ready to run the solution.

  
### Frontend     
1. **Open a terminal in the *react-client* folder and run the following commands:**
   ```Powershell
   npm i
   npm start
   ```

