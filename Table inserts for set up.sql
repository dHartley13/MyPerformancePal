USE MyPerformancePal
GO

INSERT INTO [DBO].[ACTION] ([action], ActionDescription)
SELECT
	'Own Won', 
	'Whatever action type was performed by your team was successfull'
UNION
SELECT
	'Own Lost', 
	'Whatever action type was performed by your team was unsuccessfull'
UNION
SELECT
	'Opposition Retained', 
	'Whatever action type was performed by the opposition team was successfull'
UNION
SELECT
	'Opposition Lost', 
	'Whatever action type was performed by the opposition team was unsuccessfull'



INSERT INTO [dbo].[actionDropDownLookup] (actionoptions)
select 'Scrum'
union 
select 'lineout'


