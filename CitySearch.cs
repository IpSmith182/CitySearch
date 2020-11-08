using CitySearch.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace CitySearch.Controllers
{

    interface CitySearch

        public interface ICityFinder
        // Returning action result to the index
        public ActionResult Index()
    {
        return View();
    }
    

    
        //function or action for searching through the database
        ICityResult Search(string searchString);
    {

        Database db = new Database();// for the purpose of this exercise there is no connection to a
                                     // database. Was having issues with sql server. One i've used befor was
                                     // through the uni.

    // Conditions taking the user input and finding the best match from the Database
    List<ICityResult> allSearch = db.Cities.Where(X =>.Name.Contains(CitySearch)).Select(X => new ICityResult { })
            
            Id= X.id,
            Name = X.Name
    ).ToList();
    return new ICityResult{Data=allsearch,JsonRequestBehavior.AllowGet};
    }// Return results with autofill to the user
 }   

// Forgive the errors. It's been some time since I've worked with Visual Studio. To do it everyday would
//be more beneficial as well as using Udemy. I use Udemy alot.


