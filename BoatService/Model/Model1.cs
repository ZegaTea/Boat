namespace BoatService.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<conbao> conbaos { get; set; }
        public virtual DbSet<hanhtrinh> hanhtrinhs { get; set; }
        public virtual DbSet<hanhtrinhbao> hanhtrinhbaos { get; set; }
        public virtual DbSet<loaitau> loaitaus { get; set; }
        public virtual DbSet<quocgia> quocgias { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tauthuyen> tauthuyens { get; set; }
        public virtual DbSet<tinhtrang> tinhtrangs { get; set; }
        public virtual DbSet<vitribao> vitribaos { get; set; }
        public virtual DbSet<vitritauthuyen> vitritauthuyens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<conbao>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<conbao>()
                .HasMany(e => e.hanhtrinhbaos)
                .WithOptional(e => e.conbao)
                .HasForeignKey(e => e.maconbao);

            modelBuilder.Entity<hanhtrinh>()
                .Property(e => e.matauthuyen)
                .IsUnicode(false);

            modelBuilder.Entity<hanhtrinh>()
                .HasMany(e => e.vitritauthuyens)
                .WithOptional(e => e.hanhtrinh)
                .HasForeignKey(e => e.mahanhtrinh);

            modelBuilder.Entity<hanhtrinhbao>()
                .Property(e => e.maconbao)
                .IsUnicode(false);

            modelBuilder.Entity<hanhtrinhbao>()
                .HasMany(e => e.vitribaos)
                .WithOptional(e => e.hanhtrinhbao)
                .HasForeignKey(e => e.mahanhtrinh);

            modelBuilder.Entity<loaitau>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<loaitau>()
                .HasMany(e => e.tauthuyens)
                .WithOptional(e => e.loaitau)
                .HasForeignKey(e => e.maloaitau);

            modelBuilder.Entity<quocgia>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<quocgia>()
                .HasMany(e => e.tauthuyens)
                .WithOptional(e => e.quocgia)
                .HasForeignKey(e => e.maquocgia);

            modelBuilder.Entity<tauthuyen>()
                .Property(e => e.ma)
                .IsUnicode(false);

            modelBuilder.Entity<tauthuyen>()
                .Property(e => e.MMSI)
                .IsUnicode(false);

            modelBuilder.Entity<tauthuyen>()
                .Property(e => e.maloaitau)
                .IsUnicode(false);

            modelBuilder.Entity<tauthuyen>()
                .Property(e => e.maquocgia)
                .IsUnicode(false);

            modelBuilder.Entity<tauthuyen>()
                .Property(e => e.image)
                .IsUnicode(false);

            modelBuilder.Entity<tauthuyen>()
                .HasMany(e => e.hanhtrinhs)
                .WithOptional(e => e.tauthuyen)
                .HasForeignKey(e => e.matauthuyen);

            modelBuilder.Entity<tinhtrang>()
                .HasMany(e => e.conbaos)
                .WithOptional(e => e.tinhtrang)
                .HasForeignKey(e => e.matinhtrang);
        }
    }
}
