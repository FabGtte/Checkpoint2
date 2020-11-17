USE CheckpointBravo
GO
SELECT lastname, AVG(grade) AS ExamAverage FROM Exam
INNER JOIN Student ON FK_Exam = ExamId 
GROUP BY lastname, grade
