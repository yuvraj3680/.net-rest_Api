namespace BLL;
using DAL;
using BOL;
public class HRManager
{    
public static List<Department> GetAllDepartmentsFromDAL()
{
List<Department>list=new List<Department>();
list=DBmanager.GetallDepartments();
    return list;
}

public bool insert(int id,string name,string location)
{
    return DBmanager.Insert(id,name,location);
} 

}
