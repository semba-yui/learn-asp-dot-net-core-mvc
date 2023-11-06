CREATE TABLE [dbo].[person](
    [id] [int] IDENTITY(1,1) NOT NULL,
    [name] [varchar](50) NOT NULL,
    [age] [int] NOT NULL,
    CONSTRAINT [PK_person1] PRIMARY KEY CLUSTERED
    (
        [id] ASC
    )
)