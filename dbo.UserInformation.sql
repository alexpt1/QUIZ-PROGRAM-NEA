CREATE TABLE [dbo].[UserInformation] (
    [UserID]   INT NOT NULL IDENTITY,
    [Username] VARCHAR (50) NOT NULL,
    [Password] VARCHAR (50) NOT NULL,
    [Age]      INT          NOT NULL,
    [Email]    VARCHAR (50) NOT NULL,
    [Key]      INT          NOT NULL
);

