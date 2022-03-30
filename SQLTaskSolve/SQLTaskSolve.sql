CREATE DATABASE ShopDatabase

USE [ShopDatabase]
GO

CREATE TABLE products (
	product_id smallint PRIMARY KEY not null IDENTITY(1,1),
	product_name varchar(40) not null
)
GO

INSERT INTO [dbo].[products]
           ([product_name])
     VALUES
('Chai'),
('Chang'),
('Aniseed Syrup'),
('Chef Anton''s Cajun Seasoning'),
('Chef Anton''s Gumbo Mix'),
('Grandma''s Boysenberry Spread'),
('Uncle Bob''s Organic Dried Pears'),
('Northwoods Cranberry Sauce'),
('Mishi Kobe Niku'),
('Ikura'),
('Queso Cabrales'),
('Queso Manchego La Pastora'),
('Konbu'),
('Tofu'),
('Genen Shouyu'),
('Pavlova'),
('Alice Mutton'),
('Carnarvon Tigers'),
('Teatime Chocolate Biscuits'),
('Sir Rodney''s Marmalade'),
('Sir Rodney''s Scones'),
('Gustaf''s Knäckebröd'),
('Tunnbröd'),
('Guaraná Fantástica'),
('NuNuCa Nuß-Nougat-Creme'),
('Gumbär Gummibärchen'),
('Schoggi Schokolade'),
('Rössle Sauerkraut'),
('Thüringer Rostbratwurst'),
('Nord-Ost Matjeshering'),
('Gorgonzola Telino'),
('Mascarpone Fabioli'),
('Geitost'),
('Sasquatch Ale'),
('Steeleye Stout'),
('Inlagd Sill'),
('Gravad lax'),
('Côte de Blaye'),
('Chartreuse verte'),
('Boston Crab Meat'),
('Jack''s New England Clam Chowder'),
('Singaporean Hokkien Fried Mee'),
('Ipoh Coffee'),
('Gula Malacca'),
('Rogede sild'),
('Spegesild'),
('Zaanse koeken'),
('Chocolade'),
('Maxilaku'),
('Valkoinen suklaa'),
('Manjimup Dried Apples'),
('Filo Mix'),
('Perth Pasties'),
('Tourtière'),
('Pâté chinois'),
('Gnocchi di nonna Alice'),
('Ravioli Angelo'),
('Escargots de Bourgogne'),
('Raclette Courdavault'),
('Camembert Pierrot'),
('Sirop d''érable'),
('Tarte au sucre'),
('Vegie-spread'),
('Wimmers gute Semmelknödel'),
('Louisiana Fiery Hot Pepper Sauce'),
('Louisiana Hot Spiced Okra'),
('Laughing Lumberjack Lager'),
('Scottish Longbreads'),
('Gudbrandsdalsost'),
('Outback Lager'),
('Flotemysost'),
('Mozzarella di Giovanni'),
('Röd Kaviar'),
('Longlife Tofu'),
('Rhönbräu Klosterbier'),
('Lakkalikööri'),
('Original Frankfurter grüne Soße')
GO

CREATE TABLE categories (
	category_id smallint PRIMARY KEY not null IDENTITY(1,1),
	category_name varchar(40) not null
)
GO

INSERT INTO [dbo].[categories]
           ([category_name])
     VALUES
('Beverages'),
('Condiments'),
('Confections'),
('Dairy Products'),
('Grains/Cereals'),
('Meat/Poultry'),
('Produce'),
('Seafood')
GO

CREATE TABLE products_categories (
	id smallint primary key not null identity(1,1),
	product_id smallint not null,
	category_id smallint not null,
	CONSTRAINT FK_product_id FOREIGN KEY (product_id) REFERENCES products(product_id),
	CONSTRAINT FK_category_id FOREIGN KEY (category_id) REFERENCES categories(category_id)
)
GO

INSERT INTO [dbo].[products_categories]
           ([product_id]
           ,[category_id])
VALUES
(1, 1),
(1, 2),
(2, 1),
(2, 3),
(3, 2),
(3, 5),
(3, 1),
(4, 2),
(5, 2),
(6, 2),
(7, 7),
(7, 4),
(7, 8),
(8, 2),
(9, 6),
(9, 4),
(10, 8),
(11, 4),
(12, 4),
(13, 8),
(14, 7),
(24, 1),
(25, 3),
(26, 3),
(26, 2),
(26, 7),
(27, 3),
(28, 7),
(29, 6),
(30, 8),
(31, 4),
(32, 4),
(33, 4),
(34, 1),
(35, 1),
(36, 8),
(37, 8),
(38, 1),
(39, 1),
(40, 8),
(41, 8),
(42, 5),
(43, 1),
(43, 2),
(43, 5),
(44, 2),
(45, 8),
(45, 5),
(45, 2),
(46, 8),
(46, 4),
(46, 2),
(47, 3),
(48, 3),
(60, 4),
(61, 2),
(62, 3),
(63, 2),
(64, 5),
(65, 2),
(66, 2),
(66, 4),
(66, 6),
(67, 1),
(68, 3),
(68, 6),
(68, 4),
(69, 4),
(70, 1),
(71, 4),
(71, 3),
(71, 2),
(72, 4),
(73, 8),
(74, 7),
(75, 1),
(75, 2),
(75, 3),
(76, 1),
(77, 2)
GO

SELECT products.product_id, product_name, categories.category_id, category_name
FROM products
LEFT JOIN products_categories ON products_categories.product_id = products.product_id
LEFT JOIN categories ON products_categories.category_id = categories.category_id
GO