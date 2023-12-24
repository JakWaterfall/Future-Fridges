# Future Fridges
This is the source code repository for the Future Fridges application being developed for SOFT30121: Advanced Analysis & Design.

## Code Architecture
The source code is broken down into 3 layer: Web, Business and Data. Each of these have their own purpose outlined below.

### Web
This layer consists of the majority of the plain Razor Pages and HTML content (eg. .cshtml, .cshtml.cs). These will be the content visible to the end user and the actions being performed at the highest level. This will all be under the "Pages" Folder within the project.

### Business
This layer is the layer performing the actual calculations, verifications, retrieval, etc. It essentially performs the "heavy lifting" of the codebase. This layer will main consist of .cs files and will be kept under the "Business" folder (with subfolders for each category such as StockManagement).

### Data
This layer is the layer responsible for interfacing with the database, such as making the actual database connection and retrieving the data, as well as converting it to appropriate business classes. These will also mainly consist of .cs files and will be stored under the "Data" folder (with appropriate subfolders as mentioned above)

## Code flow
The code will flow between these layers when performing actions as outlined with the example of retrieving an item of stock below.

**Web Layer** - User enters a stock item ID and clicks the "search" button. This button click is handled in the cshtml.cs for the page, within an appropriate method. This method will then create a new instance of the Business class "StockItemController". It will then call the method "GetStockItem" from this Business class.

![image](https://user-images.githubusercontent.com/34271471/194389539-233a90bd-40cc-4e9f-be6e-2e3123fad3f7.png)


**Business Layer** - The business class method for GetStockItem will be run, and this will make a call to "StockItemRepository" GetStockItem method in the Data layer.

![image](https://user-images.githubusercontent.com/34271471/194389934-761abaee-6257-42c0-8ef6-81208abef6a1.png)

![image](https://user-images.githubusercontent.com/34271471/194389670-8b788413-dc69-45cb-a2d1-471fb7b93a7d.png)


**Data Layer** - The GetStockItem method in the data class will be run, and will contact the database and fetch the appropriate record, then convert it into the appropriate Model to be used in the codebase.

![image](https://user-images.githubusercontent.com/34271471/194389824-0bbad505-b462-4170-82ca-55f0ab977b8a.png)

![image](https://user-images.githubusercontent.com/34271471/194389776-5ed4c9d8-b0c9-44f8-8b6f-60dc49d83f41.png)

The model from the Data layer is then returned to the Business method, which in turn returns it to the Web layer to display to the user.

## Models/Enums
We should use Models for every database item that is going to be represented within the codebase, this allows us to convert the raw data from the database into an easy to use format within the code that can be passed between pages. For values that have a few specific options that will not change, we should use Enums and then store the number value of the enum in the database rather than the word to save memory and reduce complexity.

### Example Model
![image](https://user-images.githubusercontent.com/34271471/194391956-06314b01-7b5e-4e06-8639-678e4787cbc5.png)

### Example Enum
![image](https://user-images.githubusercontent.com/34271471/194392033-71b6efd3-d02e-44bd-bb2e-d8ea242abea8.png)

#### Login Screen
<img src="https://github.com/JakWaterfall/Future-Fridges/assets/65239251/ea311496-babb-43c1-b4ea-f3b5d6c82bbe" width="75%" margin="50">

#### Manage Stock UI
<img src="https://github.com/JakWaterfall/Future-Fridges/assets/65239251/15393241-d40e-40df-881a-bd4d767cf301" width="75%">


