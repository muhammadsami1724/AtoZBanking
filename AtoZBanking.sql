Create Database AtoZBanking
GO
Use AtoZBanking
Go
Create Table Accounts(AccountId int Identity(1,1) not null , AccountName nvarchar(max) not null, Balance decimal not null,  PRIMARY KEY (AccountId))
GO
Create Table Transactions(TransactionId int Identity(1,1) not null, FromAccount nvarchar(max) not null, ToAccount nvarchar(max) not null,
TransactionDate DateTime not null, AmountDebited decimal not null, FromAccountBalance decimal not null, ToAccountBalance decimal not null,  PRIMARY KEY (TransactionId))
GO
