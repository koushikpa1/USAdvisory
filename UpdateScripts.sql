USE [USAdvisory]
GO

/****** Object:  StoredProcedure [dbo].[UI_GetPortfolioByTransactionId]    Script Date: 04/09/2010 17:10:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[UI_GetPortfolioByTransactionId]
@stockTransactionId int	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * from PortfolioTransactions where StockTransactionId=@stockTransactionId
END

GO



SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[UI_GetPremiumServices]  
@TypeOfTradeId int  
AS
BEGIN        
IF @TypeOfTradeId = 1 or  @TypeOfTradeId =2
BEGIN       
  Select * from PremiumServices where   
  TypeOfTradeId IN (1,2) Order BY PremiumServiceDate DESC 
END
ELSE       
  Select * from PremiumServices where   
  TypeOfTradeId = @TypeOfTradeId Order BY PremiumServiceDate DESC  
END
GO

SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER OFF
GO

