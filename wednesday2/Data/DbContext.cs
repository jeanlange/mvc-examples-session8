using System;
using Microsoft.EntityFrameworkCore; // This lets us interact with the DB.

namespace wednesday2.Models
{
    public class BlogDbContext : DbContext // DbContext is the generic stuff that all db-backed websites do. Inside this class we're making that inherits from DbContext, we'll set up the stuff that's specific to OUR db-backed website.
    {
        // here's the constructor! make sure it does DbContext stuff instead of a new empty one (new empty is default, so we have to write this one).
        // :base(options) means: run the parent constructor - the one from DbContext - with the same options as were passed to me.
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
    : base(options)
        {
        }

        // create a data structure that makes a table in the DB.
        //    The DbSet will contain data of the type: 'Blog' (That's what the Nixons mean)
        // we can use the 'Blog' type because we're in the same namespace as it - 'wednesday2.Models'
        //    It's not the FOLDER STRUCTURE that MVC looks at as the truth, it's the NAMESPACE.

        // in our code, the table will be called 'Blogs'.
        public DbSet<Blog> Blogs { get; set; }
    }
}
