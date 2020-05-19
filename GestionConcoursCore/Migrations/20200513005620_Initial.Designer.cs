﻿// <auto-generated />
using System;
using GestionConcoursCore.Data;
using GestionConcoursCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GestionConcoursCore.Migrations
{
    [DbContext(typeof(GestionConcourCoreDbContext))]
    [Migration("20200513005620_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionConcoursCore.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.AnneeUniversitaire", b =>
                {
                    b.Property<string>("Cne");

                    b.Property<string>("AnneUni1");

                    b.Property<string>("AnneUni2");

                    b.Property<string>("AnneUni3");

                    b.Property<string>("Redoublant1");

                    b.Property<string>("Redoublant2");

                    b.Property<string>("Redoublant3");

                    b.Property<double>("Semestre1");

                    b.Property<double>("Semestre2");

                    b.Property<double>("Semestre3");

                    b.Property<double>("Semestre4");

                    b.Property<double>("Semestre5");

                    b.Property<double>("Semestre6");

                    b.HasKey("Cne");

                    b.ToTable("AnneeUniversitaires");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Baccalaureat", b =>
                {
                    b.Property<string>("Cne");

                    b.Property<string>("DateObtentionBac");

                    b.Property<string>("MentionBac");

                    b.Property<double>("NoteBac");

                    b.Property<string>("TypeBac");

                    b.HasKey("Cne");

                    b.ToTable("Baccalaureats");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Candidat", b =>
                {
                    b.Property<string>("Cne")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admis");

                    b.Property<string>("Adresse");

                    b.Property<string>("Cin")
                        .IsRequired();

                    b.Property<bool>("Conforme");

                    b.Property<bool>("Convoque");

                    b.Property<DateTime>("DateInscription");

                    b.Property<DateTime>("DateNaissance");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Gsm");

                    b.Property<int>("ID");

                    b.Property<string>("LieuNaissance");

                    b.Property<string>("Matricule");

                    b.Property<string>("Nationalite");

                    b.Property<int>("Niveau");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.Property<double>("NotePreselec");

                    b.Property<int>("Num_dossier");

                    b.Property<string>("Password");

                    b.Property<string>("Photo");

                    b.Property<string>("Prenom")
                        .IsRequired();

                    b.Property<bool>("Presence");

                    b.Property<string>("Sexe");

                    b.Property<string>("Telephone");

                    b.Property<int>("Verified");

                    b.Property<string>("Ville");

                    b.Property<bool>("listDatt");

                    b.HasKey("Cne");

                    b.HasIndex("ID");

                    b.ToTable("Candidats");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.ConcourEcrit", b =>
                {
                    b.Property<string>("Cne");

                    b.Property<double>("NoteGenerale");

                    b.Property<double>("NoteMath");

                    b.Property<double>("NoteSpecialite");

                    b.HasKey("Cne");

                    b.ToTable("CouncourEcrits");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.ConcourOral", b =>
                {
                    b.Property<string>("Cne");

                    b.Property<int>("Classement");

                    b.HasKey("Cne");

                    b.ToTable("CouncourOrals");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.ConfigurationPreselection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoeffBac");

                    b.Property<int>("CoeffS1");

                    b.Property<int>("CoeffS2");

                    b.Property<int>("CoeffS3");

                    b.Property<int>("CoeffS4");

                    b.Property<int>("CoeffS5");

                    b.Property<int>("CoeffS6");

                    b.Property<string>("Filiere");

                    b.Property<double>("NoteJoker");

                    b.Property<double>("NoteSeuil");

                    b.Property<string>("TypeDiplome");

                    b.HasKey("ID");

                    b.ToTable("ConfigurationPreselections");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.ConfigurationSelection", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CoeffMath");

                    b.Property<int>("CoeffSpecialite");

                    b.Property<string>("Filiere");

                    b.Property<int>("NbrPlace");

                    b.Property<int>("NbrPlaceListAtt");

                    b.Property<string>("Niveau");

                    b.Property<double>("NoteMin");

                    b.Property<string>("TypeClassement");

                    b.HasKey("ID");

                    b.ToTable("ConfigurationSelections");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Corbeille", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNE");

                    b.HasKey("ID");

                    b.ToTable("Corbeilles");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Diplome", b =>
                {
                    b.Property<string>("Cne");

                    b.Property<string>("Etablissement");

                    b.Property<double>("NoteDiplome");

                    b.Property<string>("Specialite");

                    b.Property<string>("Type");

                    b.Property<string>("VilleObtention");

                    b.HasKey("Cne");

                    b.ToTable("Diplomes");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Epreuves", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Annee")
                        .IsRequired();

                    b.Property<string>("Matiere")
                        .IsRequired();

                    b.Property<string>("NomFichier")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("Epreuves");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Fichier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cne");

                    b.Property<string>("nom");

                    b.HasKey("ID");

                    b.ToTable("Fichiers");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Filiere", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nom");

                    b.HasKey("ID");

                    b.ToTable("Filieres");
                });

            modelBuilder.Entity("GestionConcoursCore.Models.AnneeUniversitaire", b =>
                {
                    b.HasOne("GestionConcoursCore.Models.Candidat", "Candidat")
                        .WithOne("AnneeUniversitaire")
                        .HasForeignKey("GestionConcoursCore.Models.AnneeUniversitaire", "Cne")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Baccalaureat", b =>
                {
                    b.HasOne("GestionConcoursCore.Models.Candidat", "Candidat")
                        .WithOne("Baccalaureat")
                        .HasForeignKey("GestionConcoursCore.Models.Baccalaureat", "Cne")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Candidat", b =>
                {
                    b.HasOne("GestionConcoursCore.Models.Filiere", "Filiere")
                        .WithMany("Candidats")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionConcoursCore.Models.ConcourEcrit", b =>
                {
                    b.HasOne("GestionConcoursCore.Models.Candidat", "Candidat")
                        .WithOne("CouncourEcrit")
                        .HasForeignKey("GestionConcoursCore.Models.ConcourEcrit", "Cne")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionConcoursCore.Models.ConcourOral", b =>
                {
                    b.HasOne("GestionConcoursCore.Models.Candidat", "Candidat")
                        .WithOne("CouncourOral")
                        .HasForeignKey("GestionConcoursCore.Models.ConcourOral", "Cne")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("GestionConcoursCore.Models.Diplome", b =>
                {
                    b.HasOne("GestionConcoursCore.Models.Candidat", "Candidat")
                        .WithOne("Diplome")
                        .HasForeignKey("GestionConcoursCore.Models.Diplome", "Cne")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
