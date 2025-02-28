-- Started at 2:27PM PHT
-- Created tables
-- Seeded data into the tables

SELECT c.[company_code], c.[founder], lm.[count] [lead managers], sm.[count] [senior managers], m.[count] [managers], e.[count] [employees] FROM [Company] c
	INNER JOIN 
		(SELECT [company_code], COUNT(1) [count] FROM [Lead_Manager] GROUP BY [company_code]) lm ON c.[company_code] = lm.[company_code]
	INNER JOIN 
		(SELECT [company_code], COUNT(1) [count] FROM [Senior_Manager] GROUP BY [company_code]) sm ON c.[company_code] = sm.[company_code]
	INNER JOIN 
		(SELECT [company_code], COUNT(1) [count] FROM [Manager] GROUP BY [company_code]) m ON c.[company_code] = m.[company_code]
	INNER JOIN 
		(SELECT [company_code], COUNT(1) [count] FROM [Employee] GROUP BY [company_code]) e ON c.[company_code] = e.[company_code]
ORDER BY c.[company_code] ASC;

-- Finished at 2:55PM PHT


-- TEST: Counter checker queries:
SELECT COUNT(1) FROM [Lead_Manager];

SELECT COUNT(1) FROM [Senior_Manager];

SELECT COUNT(1) FROM [Manager];

SELECT COUNT(1) FROM [Employee];