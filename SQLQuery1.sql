-- 1. Pehle check karein ke kya Email abhi bhi hai? (Agar hai to ura do)
IF EXISTS (SELECT * FROM sys.columns WHERE Name = 'Email' AND Object_ID = Object_ID('Students'))
BEGIN
    ALTER TABLE Students DROP COLUMN Email;
END

-- 2. DeptID wala column urane ka sab se asaan tareeqa (Manual Force)
-- Agar oper wali query ne error dia tha, to ab direct ye try karein:
ALTER TABLE Students DROP COLUMN DeptID;