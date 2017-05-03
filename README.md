# Shoes
A sales website with roles for sales associate and managers to sign into 
#### Tammy Dang and Caitlin Hines 

## Setup/Installation Requirements
* Clone from GitHub 
In SQL
  * CREATE DATABASE SonOfCod
  * GO
  * Execute 
* Open up project in Visual Studios
* Run the project

## Users Stories 
* Login in as sales associate or manager 
* As a sales associate the user can: 
  * see complete inventory to help customers
  * make a sale, which reduces inventory and increases revenue
  * process a return which returns an item to inventory and credits a refund
  * see all of my sales, and make comments that only I can see
  * calculate my commission based on my individual sales 
* As a manager I can perform the following actions on a single page using AJAX
  * see inventory AND costs for inventory items
  * review and edit sales by all sales associates, to correct for errors
  * view sales associate comments on sales
  * see commission for all sales associates
  * add or remove sales associates
  * add new inventory for sale, including item cost and sale price
  * see the total balance sheet for the entire store (revenue - costs = profit)
  
## Specs 
* Create roles to differ between sales associate and manager
* For sales associates:
  * List all inventory on index page 
  * Create sell button which will decrease inventory by -1 and increase revenue based on item price 
  * Process a return which returns item to inventory and credits a refund 
  * List all sales and create a comments section
  * Calculate a commission based on the number of items sold 
 * For managers: 
  * List all inventory and costs for inventory items.
  * List all sales by individual sales associates.
  * View sales associates comments on sales.
  * List commission by sales associate. 
  * Create or delete sales associates.
  * Create items for inventory including price and sale price.
  * List profit sheet for all sales in store.
  
  

## Support and contact details
Contact me at dangitstammy@gmail.com

## Technologies Used
.NET, SSMS, Visual Studios

##Link to GitHub
[ "GitHub", "Page" ](https://github.com/dangtammy/Son-Of-Cod)

### License
Copyright (c) 2017 *Tammy Dang*
