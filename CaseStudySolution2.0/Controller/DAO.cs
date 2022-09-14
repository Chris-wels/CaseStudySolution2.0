using CaseStudySolution2._0.Models.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudySolution2._0.Controller
{
    internal class DAO
    {
        static public void addCustomer(Customer cust)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext())
            {
                ctx.Customers.Add(cust);
                ctx.SaveChanges();

            }
        }
        static public Customer searchCustomer(int cid)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext())
            {

                return ctx.Customers.Include(ct => ct.CustomerNavigation).Where(c => c.CustomerId == cid).FirstOrDefault();
            }
        }
        static public void addEmployee(Employee em)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext())
            {
                ctx.Employees.Add(em);
                ctx.SaveChanges();

            }

        }
        static public Employee searchEmployee(int eid)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext())
            {
                return ctx.Employees.Include(et => et.EmployeeNavigation).Where(e => e.EmployeeId == eid).FirstOrDefault();
            }
        }
        static public void updateEmployee(Employee em, Person ep)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext())
            {
                ctx.Entry(em).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.Entry(ep).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();
            }
        }
        static public void updateCustomer(Customer cust, Person cp)
        {
            using (DAD_ChristianContext ctx = new DAD_ChristianContext())
            {
                ctx.Entry(cust).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.Entry(cp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                ctx.SaveChanges();

            }

        }
        //static public List<Customer> showCustomers()
        //{
        //    using (DAD_ChristianContext ctx = new DAD_ChristianContext())
        //    {
        //        return ctx.Customers.Include(c => c.CustomerNavigation).ToList();
        //    }
        //}
        //static public List<Employee> showEmployee()
        //{
        //    using (DAD_ChristianContext ctx = new DAD_ChristianContext())
        //    {
        //        return ctx.Employees.Include(em => em.EmployeeNavigation).ToList();
        //    }
        //}
    }
}
