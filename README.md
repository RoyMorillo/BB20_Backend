
# 🔧Breakthrough Broker 2.0 - .NET BackEnd

## 🤖 Github Repository

https://github.com/RoyMorillo/BB20_Backend/tree/Development

## 🛠️ Installation
 Requirements:

- .NET 6.0
- Visual Studio 2022
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
- Run Visual studio.

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
    - /subcategory/GetForDropDown [GET]
    - /interiorcategory/getall [GET]
    - /interiorcategory/GetDataById/{interiorCategoryId} [GET]
    - /interiorcategory/GetForDropDown [GET]

## 👓 Authors

- [@RoyMorrillo](https://github.com/RoyMorillo)



