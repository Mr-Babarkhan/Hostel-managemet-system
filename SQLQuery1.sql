create table rooms
(
	r_id varchar (10) primary key,
	r_no int,
	r_status varchar (50),
	r_book varchar (50),

)

create table hostel
(
	h_id int primary key,
	h_name varchar (50),
	h_fname varchar (50),
	h_gender varchar (50),
	h_age varchar (50),
	h_address varchar (50),
	h_phone varchar (50) ,
	h_home_no varchar (50),
	h_email varchar (50),
	h_institute varchar (50),
	h_status varchar (50),
	h_intake date,
	h_room  varchar (10) foreign key (h_room) references rooms(r_id),
)
create table roles
(
	r_id int primary key,
	r_name varchar (50),
	r_salary varchar (50)
)
create table employees
(
	e_id int primary key,
	e_name varchar (50),
	e_fname varchar (50),
	e_gender varchar (50),
	e_address varchar (50),
	e_phone varchar (50),
	e_mail varchar (50),
	e_r_id int foreign key(e_r_id) references roles(r_id)
)

create table payments 
(
	p_id int primary key,
	p_amount varchar (50),
	p_paid varchar (50),
	p_remaining varchar (50),
	p_date date,
	P_month varchar (50),
	p_h_id int foreign key(p_h_id) references hostel(h_id)
)
create table visitors
(
	v_id int primary key,
	v_name varchar (50),
	v_fname varchar (50),
	v_h int foreign key(v_h) references hostel(h_id),
	v_relation varchar (50)
)
create table account 
(
	u_id varchar (50) primary key ,
	u_pass varchar (50)
)
create table salaries 
(
	s_id int primary key,
	s_amount varchar (50),
	s_paid varchar (50),
	s_remaining varchar (50),
	s_date date,
	s_month varchar(50),
	s_e_id int foreign key(s_e_id) references employees(e_id)
)
	
select * from salaries
select * from account
select * from hostel
select * from account
select * from employees
select * from rooms
select * from roles
select * from payments