-- Delete all data from the Students table
DELETE FROM Students;

-- Reset the identity seed
DBCC CHECKIDENT ('Students', RESEED, 0); 