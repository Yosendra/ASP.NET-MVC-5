namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e55812ce-3f2d-45b8-8938-3e1e55fde95a', N'admin@mailinator.com', 0, N'ALLP+vb4TIqvw36M0l2VeyaDdq/WvDKY9Mlwezk0R0mPUorJ4ht4gauLAboeZyo06Q==', N'048982e1-cb7e-4669-a5ce-dcf27bc8c9b5', NULL, 0, 0, NULL, 1, 0, N'admin@mailinator.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'cd74dd04-25f0-4a20-bb60-ac391409b8cb', N'guest@mailinator.com', 0, N'AKClK8AB2BRMOJNBYMsUXCq2/n8u4OMjzaCBgz/sf8DP0/vhVrxcqPEPT/Tgd4I7xw==', N'2ae237c2-23e7-4d22-a481-c3125051ee0b', NULL, 0, 0, NULL, 1, 0, N'guest@mailinator.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'6796b432-012e-47a9-9a2d-df8038b36229', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e55812ce-3f2d-45b8-8938-3e1e55fde95a', N'6796b432-012e-47a9-9a2d-df8038b36229')
");
        }
        
        public override void Down()
        {
        }
    }
}
