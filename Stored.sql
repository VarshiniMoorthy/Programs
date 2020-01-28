--use[DataCollection];
create proc StoredProceduress(@name varchar(10),@dob date,@doj date,@sex varchar(4),@prof1 varchar(8),@prof2 varchar(8),@salary numeric(5,4))
AS
begin
insert into Programmer(name,dob,doj,sex,prof1,prof2,salary)
values(@name,@dob,@doj,@sex,@prof1,@prof2,@salary)
end
--select * from Programmer;
