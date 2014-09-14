using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreeJS.DAL;
using TreeJS.Models;
using System.Data;
using System.Data.Entity;

namespace TreeJS.Controllers
{
    public class DefaultController : Controller
    {
        private DBForDNSContext db = new DBForDNSContext();
        // GET: Default
        public ActionResult Index()
        {
            var tree = db.Files.OrderBy(f => f.ID).ToList();
            var root = tree.Where(f => f.PathID == null).FirstOrDefault();
            SetChildren(root, tree);

            return View(root);
        }

        private void SetChildren(File root, List<File> tree)
        {
            var childs = tree.Where(f => f.PathID == root.ID).ToList();
            if (childs.Count > 0)
            {
                foreach (var child in childs)
                {
                    SetChildren(child, tree);
                    root.Files.Add(child);
                }

            }
        }

        public ActionResult Save(string childId, string parentId)
        {
            int child = GetModifiedPos(childId);
            int parent = GetModifiedPos(parentId);
            if (parent == 0)
                return null;
            var tree = db.Files.OrderBy(f => f.ID).ToList();
            var node = tree.Where(f => f.ID == child).FirstOrDefault();

            node.PathID = parent;
            
            db.SaveChanges();

            return null;

        }

        private int GetModifiedPos(string position)
        {
              return Convert.ToInt32(position.Substring(position.IndexOf('_') + 1));
        }
    }
}