# Point of Sale System in C#

This is a point of sale system developed as part of a university course. The system is implemented in *C#* using *Windows Forms* and connected to a *SQL Server* database for managing inventory, customers, and sales.

## Features

- *Product Management:* Add, modify, and delete products from the inventory.
- *Customer Management:* Register and update customer information.
- *Sales Management:* Process sales and generate invoices.
- *Automatic Inventory Update:* Product quantities are updated automatically after each sale.
- *SQL Database Integration:* All data is stored in a SQL Server database.

## Technologies Used

- *Language:* C#.
- *Framework:* .NET (Windows Forms).
- *Database:* SQL Server.
- *IDE:* Visual Studio.

How to Use the System

	1.	Product Management:
	•	Navigate to the “Products” section to add new products to the inventory.
	•	You can also modify or delete products as needed.
	2.	Customer Management:
	•	Register new customers with their first name, last name, and loyalty card number.
	3.	Sales Processing:
	•	In the sales section, select the desired products and process the sale. The inventory will update automatically.
	•	The system will generate an invoice with the details of the purchase.
	4.	View Invoices:
	•	You can access a sales history and review past invoices from the system.

Database Structure

The system uses a SQL Server database with the following key tables:

	•	Products:
	•	CodigoProducto: Unique product identifier.
	•	NombreProducto: Product name.
	•	Precio: Product price.
	•	UnidadesEnExistencia: Available inventory quantity.
	•	Customers:
	•	IdCliente: Unique customer identifier.
	•	Nombre: Customer’s first name.
	•	Apellido: Customer’s last name.
	•	NumeroTarjeta: Loyalty card number.
	•	Sales:
	•	IdVenta: Unique sale identifier.
	•	FechaVenta: Date of the transaction.
	•	Total: Sale total.

Screenshots

(Comming Soon)

License

This project was created for educational purposes and is available under the MIT License.