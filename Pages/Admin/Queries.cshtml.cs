﻿using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace budoco.Pages
{
    public class QueriesModel : PageModel
    {

        public DataTable dt;
        public string singular_table_name = "Query";


        public void OnGet()
        {
            if (!bd_util.check_user_permissions(HttpContext, bd_util.MUST_BE_ADMIN))
                return;

            string sql = @"select * from queries order by qu_name";
            dt = bd_db.get_datatable(sql);
        }
    }
}
