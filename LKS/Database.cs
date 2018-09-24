using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LKS.smkTableAdapters;

namespace LKS
{
    class Database
    {
        public static smk Data { get; } = new smk();
        static EmployeeTableAdapter EmployeeTableAdapter = new EmployeeTableAdapter();
        static MenuTableAdapter MenuTableAdapter = new MenuTableAdapter();
        static MemberTableAdapter MemberTableAdapter = new MemberTableAdapter();
        static OrderTableAdapter OrderTableAdapter = new OrderTableAdapter();
        static DetailMenuTableAdapter DetailMenuTableAdapter = new DetailMenuTableAdapter();
        static DetailPackageTableAdapter DetailPackageTableAdapter = new DetailPackageTableAdapter();
        static PackageTableAdapter PackageTableAdapter = new PackageTableAdapter();
        static OdbcCommandBuilder EmployeeBuilder = new OdbcCommandBuilder(EmployeeTableAdapter.Adapter);
        static OdbcCommandBuilder MenuBuilder = new OdbcCommandBuilder(MenuTableAdapter.Adapter);
        static OdbcCommandBuilder MemberBuilder = new OdbcCommandBuilder(MemberTableAdapter.Adapter);
        static OdbcCommandBuilder OrderBuilder = new OdbcCommandBuilder(OrderTableAdapter.Adapter);
        static OdbcCommandBuilder DetailMenuBuilder = new OdbcCommandBuilder(DetailMenuTableAdapter.Adapter);
        static OdbcCommandBuilder DetailPackageBuilder = new OdbcCommandBuilder(DetailPackageTableAdapter.Adapter);
        static OdbcCommandBuilder PackageCommandBuilder = new OdbcCommandBuilder(PackageTableAdapter.Adapter);

        public static void Init()
        {
            EmployeeTableAdapter.Fill(Data.Employee);
            MenuTableAdapter.Fill(Data.Menu);
            MemberTableAdapter.Fill(Data.Member);
            PackageTableAdapter.Fill(Data.Package);
            OrderTableAdapter.Fill(Data.Order);
            DetailMenuTableAdapter.Fill(Data.DetailMenu);
            DetailPackageTableAdapter.Fill(Data.DetailPackage);
            GenerateCommands(EmployeeBuilder);
            GenerateCommands(MenuBuilder);
            GenerateCommands(PackageCommandBuilder);
            GenerateCommands(MemberBuilder);
            GenerateCommands(OrderBuilder);
            GenerateCommands(DetailMenuBuilder);
            GenerateCommands(DetailPackageBuilder);
        }
        static void GenerateCommands(OdbcCommandBuilder Builder)
        {
            Console.WriteLine(Builder.GetInsertCommand().CommandText);
            Console.WriteLine(Builder.GetUpdateCommand().CommandText);
            Console.WriteLine(Builder.GetDeleteCommand().CommandText);
        }
        public static void Commit(System.Data.DataTable table)
        {
            switch (table.TableName)
            {
                case "Employee": EmployeeTableAdapter.Adapter.Update(Data.Employee); break;
                case "Menu": MenuTableAdapter.Adapter.Update(Data.Menu); break;
                case "Order": OrderTableAdapter.Adapter.Update(Data.Order); break;
                case "DetailMenu": DetailMenuTableAdapter.Adapter.Update(Data.DetailMenu); break;
                case "DetailPackage": DetailPackageTableAdapter.Adapter.Update(Data.DetailPackage); break;
            }


            Data.AcceptChanges();
        }
        public static void Commit()
        {
            Data.AcceptChanges();
        }
        public static void Transact(System.Data.DataTable table)
        {
            switch (table.TableName)
            {
                case "Order": OrderTableAdapter.Adapter.Update(Data.Order); break;
                case "DetailMenu":
                    Console.WriteLine("command: " + DetailMenuTableAdapter.Adapter.InsertCommand);
                    DetailMenuTableAdapter.Adapter.Update(Data.DetailMenu);
                    break;
                case "DetailPackage": DetailPackageTableAdapter.Adapter.Update(Data.DetailPackage); break;
            }
        }
    }
}
