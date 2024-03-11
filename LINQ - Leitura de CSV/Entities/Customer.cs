using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ___Leitura_de_CSV.Entities
{
    internal class Customer
    {
        public string ID { get; set; }
        public string CPF { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime BirthDate { get; set; }
        public double Income { get; set; }
        public string Professional_Status { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"ID: {ID}, \n CPF: {CPF}.\n FullName: {First_Name} {Last_Name},\n " +
                $"City: {City} - {State}.\n Birthdate: {BirthDate},\n Income: {Income},\n" +
                $"Professional Status: {Professional_Status},\n Email: {Email},\nPhone: {Phone} ";
        }

        public override bool Equals(object? obj)
        {
            return obj is Customer customer &&
                   ID == customer.ID &&
                   CPF == customer.CPF &&
                   Email == customer.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, CPF, Email);
        }

        public Customer(
            string iD,
            string cPF,
            string first_Name,
            string last_Name,
            string state,
            string city,
            DateTime birthDate,
            double income,
            string professional_Status,
            string email,
            string phone)
        {
            ID = iD;
            CPF = cPF;
            First_Name = first_Name;
            Last_Name = last_Name;
            State = state;
            City = city;
            BirthDate = birthDate;
            Income = income;
            Professional_Status = professional_Status;
            Email = email;
            Phone = phone;
        }
        public Customer() { }
    }
}

