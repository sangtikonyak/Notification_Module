use notification;
select * from PopMasters;
select * from userMasters;
insert into PopMasters(POPID,POPNAME,ADDRESS,CONTACTPERSON,MOBILENUMBER,LANDLINENUMBER,STATUS) values 
('SPOP1186','Zunheboto','Zunheboto','Lumo','0000','null','A');

insert into userMasters(userid,WHATSAPPNO,POPID,MOBILENUMBER) values ('inofc1004','7005511432','SPOP1186','9862257437')

select * from PopMasters where status='a'
select * from userMasters inner join PopMasters on userMasters.POPID = PopMasters.POPID  where STATUS='a'
select userid, WHATSAPPNO, POPID, MOBILENUMBER from userMasters 