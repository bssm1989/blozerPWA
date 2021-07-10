using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DnetIndexedDb;
using DnetIndexedDb.Models;
using Microsoft.JSInterop;

namespace FirstBlazorApp.Models
{
    public class EmployeeOfflineDb:IndexedDbDatabaseModel
    {
        public EmployeeOfflineDb()
        {
            Name = "EmployeeData";
            Version = 4;
            Stores = _stores;
        }
        private IndexedDbStore _tableFieldStore => new TStore<Employee>();
        private List<IndexedDbStore> _stores => new List<IndexedDbStore>
        {
            _tableFieldStore,
        };

    }
    public class Employee
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
    }
    public class EmployeeContext : IndexedDbInterop
    {
        public EmployeeContext(IJSRuntime jSRuntime, IndexedDbOptions<EmployeeContext> options) : base(jSRuntime, options) { }
        public async Task Add(Employee employee)
        {
            var openResult = await this.OpenIndexedDb();
            var result = await this.AddItems<Employee>("Employees", new List<Employee>() { employee });
        }
        public async Task<List<Employee>> GetAll()
        {
            var openResult = await this.OpenIndexedDb();
            return await this.GetAll<Employee>("Employees");
        }
    }
}
