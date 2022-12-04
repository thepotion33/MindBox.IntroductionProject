# MindBox.IntroductionProject
Test project related to the Mindbox IT company.

# SQL Task:

```SQL
CREATE TABLE [dbo].[Products]
(
  [ProductId] INTEGER IDENTITY(1,1) NOT NULL,
  [ProductName] NVARCHAR(100) NOT NULL,
  CONSTRAINT [PK_ProductId] PRIMARY KEY CLUSTERED ([ProductId] ASC),
);

CREATE TABLE [dbo].[Categories]
(
  [CategoryId] INTEGER IDENTITY(1,1) NOT NULL,
  [CategoryName] NVARCHAR(100) NOT NULL,
  CONSTRAINT [PK_CategoryId] PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

CREATE TABLE [dbo].[PC_Relationships]
(
  [ProductId] INTEGER NOT NULL,
  [CategoryId] INTEGER NOT NULL,
  CONSTRAINT [FK_PC_Relationships_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Products] ([ProductId]),
  CONSTRAINT [FK_PC_Relationships_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId])
);

SELECT Products.ProductName, Categories.CategoryName FROM Products
LEFT JOIN PC_Relationships ON Products.ProductId = PC_Relationships.ProductId
LEFT JOIN Categories ON PC_Relationships.CategoryId = Categories.CategoryId;
```
