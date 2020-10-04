﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartToDoListAPI.DataAccess.Concrete.EntityFramework.Contexts;

namespace SmartToDoListAPI.Migrations
{
    [DbContext(typeof(EfContext))]
    [Migration("20201002232552_s1")]
    partial class s1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SmartToDoListAPI.Entities.Concrete.ToDoItem", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<byte[]>("ToDoTitleId")
                        .IsRequired()
                        .HasColumnType("varbinary(16)");

                    b.Property<int>("isDelete")
                        .HasColumnType("int");

                    b.Property<bool>("isDone")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("ToDoTitleId");

                    b.ToTable("ToDoItem");
                });

            modelBuilder.Entity("SmartToDoListAPI.Entities.Concrete.ToDoTitle", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Color")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("isDelete")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ToDoTitle");
                });

            modelBuilder.Entity("SmartToDoListAPI.Entities.Concrete.User", b =>
                {
                    b.Property<byte[]>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(16)");

                    b.Property<DateTime>("AddedDate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<int>("isDelete")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("SmartToDoListAPI.Entities.Concrete.ToDoItem", b =>
                {
                    b.HasOne("SmartToDoListAPI.Entities.Concrete.ToDoTitle", "ToDoTitle")
                        .WithMany()
                        .HasForeignKey("ToDoTitleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
