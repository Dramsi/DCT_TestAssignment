# DCT_TestAssignment
Digital Cloud Technologies - .NET Developer Test Assignment

Developer: Kalmykova A.V.

The program has been developed that displays various information related to cryptocurrencies.

The program code consists of three parts built according to the MVVM:
1) Model (Model) - model for converting the API response to a usable format.
2) Windows (View) - application windows, which are the visual part and the necessary actions.
3) Controller (ViewModel) - the part that works with API, JSON and connects the model and windows.

The application has three windows on which the following functionality was implemented:
1) Main window:
- A table with the output of a list of coins (from the open service CoinCap), containing the name, abbreviation and supply.
- Search by coin name.
- Switching to a new window with the details of the coin by double-clicking on a row in the table.
- Light and dark app theme.
- Switching to a new window with a coin converter by clicking on the corresponding button on the main window.
2) Coin details window:
- List of all information about the coin provided by the CoinCap service.
- Link to the current official website of the coin.
3) Coin converter window:
- Converter of any coins from the list with a hundred coins.
- The ability to convert not only one coin, but any number of coins.

The interface does not shine with beauty, but it is made concisely, according to the meaning and on the task.

Thank you for your time.
