using STUDY.OOP.LibraryManagement.Models;

namespace STUDY.OOP.LibraryManagement.Controllers;

internal interface IBaseController
{
    void ViewItems();
    void AddItem();
    void DeleteItem();
}
