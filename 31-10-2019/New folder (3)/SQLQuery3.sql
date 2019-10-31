CREATE TABLE dbo.Customers
(
   CustomerId        INT    NOT NULL   PRIMARY KEY, -- primary key column
   Name      [NVARCHAR](50)  NOT NULL,
   Location  [NVARCHAR](50)  NOT NULL,
   Subject     [NVARCHAR](50)  NOT NULL
);
GO
INSERT INTO dbo.Customers
   ([CustomerId],[Name],[Location],[Subject])
VALUES
   ( 1, N'Orlando', N'Australia', N''),
   ( 2, N'Keith', N'India', N'Java'),
   ( 3, N'Donna', N'Germany', N'Sql'),
   ( 4, N'Janet', N'United States', N'J2ee')
GO
Select *
from dbo.Customers;