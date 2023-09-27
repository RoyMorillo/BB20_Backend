
# 🔧Breakthrough Broker 2.0 - .NET BackEnd

## 🤖 Github Repository

https://github.com/RoyMorillo/BB20_Backend/tree/Development

## 🛠️ Installation
 Requirements:

- .NET 6.0
- Visual Studio 2022 Profesional or Superior
- SQL Server Express 2022 o Development Edition 2022.
- SQL Server Management Studio (SSMS) 

## ⚙ Setup (Run Locally)

- Install SQL Server and configure for Windows Authentication
- Install SQL Server Management Studio
- Download source code from Repository.
- Connect to Sql Server using SQL Server Management Studio.
- In Visual Studio Open the project BB20_Database.
- Copy the content of the script BB20_Create_Database.sql and run in SSMS.
- Do the same with the following scripts: 
    - BB20_Category_Structure_Data.sql
    - BB20_SubCategory_Structure_Data.sql
    - BB20_InteriorCategories_Structure_Data.sql
    - BB20_Content_Structure_Data.sql
    - BB20_ContentFile_Structure_Data.sql
    - BB20_ContentAudio_Structure_Data.sql
    - BB20_ContentDisplayOption_Structure_Data.sql
    - BB20_ContentVideo_Structure_Data.sql
- To run multiple projects at the same time, right click on the Solution of the project and go to Configure Startups Projects

![Logo](https://githubbb20.s3.amazonaws.com/startup+projects.jpg)

- Then change the configurations as follows and activate the projects wanted to run at the same time.

![Logo](https://githubbb20.s3.amazonaws.com/Start+Project+setup.jpg)

- Run the project in Visual studio with F5.

## 🔗 Links URLs

- Base URL: https://localhost:7069
- EndPonts:
    - /category/getall  [GET]
    - /category/getalltree [GET]
    - /category/GetDataById/{categoryId} [GET]
    - /category/GetForDropDown [GET]
    - /subcategory/getall [GET]
    - /subcategory/getalltree [GET]
    - /subcategory/GetDataById/{subCategoryId} [GET]
    - /subcategory/GetDataByCategoryId/{categoryId} [GET]
    - /subcategory/GetForDropDown [GET]
    - /interiorcategory/getall [GET]
    - /interiorcategory/GetDataById/{interiorCategoryId} [GET]
    - /interiorcategory/GetDataBySubCategoryId/{subCategoryId} [GET]
    - /interiorcategory/GetForDropDown [GET]
    - /content/getall [GET]
    - /content/GetDataById/{contentID} [GET]
    - /content/GetAllByTitle/{title} [GET]
    - /content/GetForDropDown
    - /content/Create [POST]
    - /content/Update [PUT]
    - /content/Delete/{contentID} [DELETE]

## 👓 Authors

- [@RoyMorrillo](https://github.com/RoyMorillo)



