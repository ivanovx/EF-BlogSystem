namespace BlogSystem.Data
{
    using System;

    using global::BlogSystem.Data.Repositories;
    using global::BlogSystem.Models;

    public interface IBlogSystemData
    {
        IUsersRepository Users { get; }

        IRepository<Post> Posts { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Tag> Tags { get; }

        int SaveChanges();
    }
}
