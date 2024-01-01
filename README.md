# MarketMingle

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
- @emotion/css": "^11.11.2,
- @emotion/react": "^11.11.1,
- @emotion/styled": "^11.11.0,
- @fontsource/roboto": "^5.0.8,
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


### Logged-In Users:
Can do the same things as a Guest,\
view a listing's details,\
create/update their listings,\
chat with other users,\
access their profile page.????


## 🔨 Features
<a name="features"/>

- CRUD operations for listings
- Uploading multiple images as files
- Chat functionality
- Dark/Light theme
- Responsive design
- Client-side validations
- Client-side search
- Client-side pagination
- JWT authentication
  
  
## 📷 Screenshots
<a name="screenshots"/>

![SS1](./images/image6.png)
![SS2](./images/image5.png)
![SS3](./images/image4.png)
![SS4](./images/image3.png)
![SS5](./images/image2.png)
![SS6](./images/image1.png)


## ⚙️ Setup
<a name="setup"/>

### Backend
1. **Clone the Repository**
2. **Open a terminal in the *api-server* folder and run the following commands:**
   ``` bash
   dotnet user-secrets init
   dotnet user-secrets set "JWTKey:ValidIssuer" "https://localhost:5001"
   dotnet user-secrets set "JWTKey:ValidAudience" "https://localhost:5001"
   dotnet user-secrets set "JWTKey:TokenExpiryTimeInHour" "10"
   dotnet user-secrets set "JWTKey:Secret" "{YOUR SECRET}"
   dotnet user-secrets set "ConnectionStrings:DatabaseConnection" "Server={YOUR SERVER NAME};Database=MarketMingle;Trusted_Connection=True;MultipleActiveResultSets=True;TrustServerCertificate=True;"
   dotnet user-secrets set "CorsOrigins:AllowedOrigins" "https://localhost:5173"
   ```
  *Please change the values in **{ }** with your own.*
  
3. **Run Backend:**
   1. Open the solution in Visual Studio or your preferred IDE.
   2. Build and run the solution.
   3. Now when the database was created with your connection string we will need to manually apply the migrations.
   4. Open a terminal in the *api-server* folder and run the following command:
    ``` bash
    dotnet ef database update
    ```
   5. You are ready to run the solution.

  
### Frontend     
1. **Open a terminal in the *react-client* folder and run the following commands:**
   ```bash
   npm install
   npm run dev
   ```
### Notes
- Make sure the the Backend API url is *https://localhost:5001* and the Frontend URL is *https://localhost:5173* because of some hardcoded values in the code. :(
