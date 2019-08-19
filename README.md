# Personal Project

This was created to allow me to brush up on my beginner C# skills after my first SDI class. I wanted a way to keep up my skills in the 3 month gap between my coding classes.

I am by no means any good at programming in C#, so this is just a way for me to practice using the methods that I learned in my introductory class, and to hopefully continue to add to and improve this project as I learn new skills.

# Goals

* Create a shopping program that will allow a user to either login, create a new user, or just shop without logging in.
  
  * If they login check that they are a registered user, if not return an error that either their username, password, or both do not match. Ask them to either reenter or to choose to register or continue.
  * If they choose to register, ask for a username (email?), then a password with restrictions on length.
  * If shopping without logging in continue to shopping list
  
*  After this step they will be presented with several choices of items for purchase. 
  
   *  They will be able to either choose to purchase the item, or to have a longer description of the item given to them, where they can then decide to buy this item or return to the main list.
   *  After selecting the item for purchase they can select the quantity they would like.
   *  The ask if they would like to continue shopping or go to their cart for checkout.
   *  Continue this process as needed until they choose to checkout
  
*  Present the user with a breakdown of their cart.
  
   *  Show each item with quantities as well as the total price of each item and the total price of all items
   *  Ask the user if they would like to edit or delete any items or their quantities. Do by one item at a time.
   *  After the user is happy with their decision give them the new total items and total price
   *  Ask for shipping information one line at a time, verifying 2 letters only for state, and a 5 number zip.
   *  Verify the users address with them, ask if it is correct  or not and allow them to either edit it or continue.

* Checkout

    * Give the user their final total, their address, then ask for either their credit card number or to cancel.
    * Have the user input the credit card number, expiration date mm/yyyy format, and CVV number.
    * Verify the credit card is numbers only and is the proper length for all fields
    * Give the user back their credit card number with all but the last 4 digits masked for security as well as the expiration date and CVV number.

* Final verification and receipt

    * Ask final time if they would like to continue with purchase of xxxx amount, to address ______, on card xxxxxxx1234.
    * Yes or No, if No select item to edit or to cancel.
    * If Yes give them a receipt of the transaction with a total amount charged on card # to address.
    * Thank them for their business ask them if they would like to shop for more or log out.