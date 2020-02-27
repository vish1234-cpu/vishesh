--ques7)Give examples of self,Inner,left outer,right outer joins.

--creating two new tables for this question. 

create table orders
(order_id int identity(100,1) primary key,
order_name varchar(50),
order_quantity int)

insert into orders(order_name,order_quantity)
values('mobile',3) 

insert into orders(order_name,order_quantity)
values('ball',2) 

insert into orders(order_name,order_quantity)
values('bat',2) 


insert into orders(order_name,order_quantity)
values('laptop',5) 


insert into orders(order_name,order_quantity)
values('fridge',1)

select * from orders 


create table customer 
(cus_id int identity(100,1) primary key,
cus_name varchar(50),
order_id int ,
foreign key(order_id) references orders(order_id) 
)

insert into customer(cus_name,order_id) 
values('mika',100)

insert into customer(cus_name,order_id) 
values('manish',100)

insert into customer(cus_name,order_id) 
values('mihir',101)

insert into customer(cus_name,order_id) 
values('mohit',103)

insert into customer(cus_name,order_id) 
values('sonal',102)

insert into customer(cus_name,order_id) 
values('ishita',101)

insert into customer(cus_name,order_id) 
values('ishan',102)

insert into customer(cus_name,order_id) 
values('kunal',104)

insert into customer(cus_name,order_id) 
values('sham',105)

insert into customer(cus_name,order_id) 
values('karan',105)

select * from customer

--self join 
select * from orders o,orders o1
where o.order_id=o1.order_id 

--left join 
select * from orders left join customer 
on orders.order_id=customer.order_id 

--right join 
select * from customer right join orders 
on customer.order_id=orders.order_id 

--inner join 
select * from orders join customer 
on orders.order_id=customer.order_id 








