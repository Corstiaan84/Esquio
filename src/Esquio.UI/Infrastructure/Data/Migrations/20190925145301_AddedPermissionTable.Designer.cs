﻿// <auto-generated />
using System;
using Esquio.EntityFrameworkCore.Store;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Esquio.UI.Infrastructure.Data.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    [Migration("20190925145301_AddedPermissionTable")]
    partial class AddedPermissionTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.ApiKeyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime>("ValidTo")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Key")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("ApiKeys");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.FeatureEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<bool>("Enabled")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ProductEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductEntityId");

                    b.ToTable("Features");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.FeatureTagEntity", b =>
                {
                    b.Property<int>("FeatureEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TagEntityId")
                        .HasColumnType("int");

                    b.HasKey("FeatureEntityId", "TagEntityId");

                    b.HasIndex("TagEntityId");

                    b.ToTable("FeatureTags");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.HistoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FeatureId")
                        .HasColumnType("int");

                    b.Property<string>("KeyValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewValues")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OldValues")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("History");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.ParameterEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<int>("ToggleEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(4000)")
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("ToggleEntityId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.PermissionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("ManagementPermission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("ReadPermission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("SubjectId")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool>("WritePermission")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("SubjectId")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.ProductEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(2000)")
                        .HasMaxLength(2000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.TagEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.ToggleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FeatureEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasAlternateKey("Type", "FeatureEntityId")
                        .HasName("IX_ToggeFeature");

                    b.HasIndex("FeatureEntityId");

                    b.ToTable("Toggles");
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.FeatureEntity", b =>
                {
                    b.HasOne("Esquio.EntityFrameworkCore.Store.Entities.ProductEntity", "ProductEntity")
                        .WithMany("Features")
                        .HasForeignKey("ProductEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.FeatureTagEntity", b =>
                {
                    b.HasOne("Esquio.EntityFrameworkCore.Store.Entities.FeatureEntity", "FeatureEntity")
                        .WithMany("FeatureTags")
                        .HasForeignKey("FeatureEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Esquio.EntityFrameworkCore.Store.Entities.TagEntity", "TagEntity")
                        .WithMany()
                        .HasForeignKey("TagEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.ParameterEntity", b =>
                {
                    b.HasOne("Esquio.EntityFrameworkCore.Store.Entities.ToggleEntity", "ToggleEntity")
                        .WithMany("Parameters")
                        .HasForeignKey("ToggleEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Esquio.EntityFrameworkCore.Store.Entities.ToggleEntity", b =>
                {
                    b.HasOne("Esquio.EntityFrameworkCore.Store.Entities.FeatureEntity", null)
                        .WithMany("Toggles")
                        .HasForeignKey("FeatureEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
