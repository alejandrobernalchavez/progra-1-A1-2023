﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ejerciciosvs
{
    class Conexion
    {
        SqlConnection miConexion = new SqlConnection(); //Conectarme a  la BD
        SqlCommand miComando = new SqlCommand(); //ejecutar consultas SQL en la base de datos.
        SqlDataAdapter miAdaptador = new SqlDataAdapter(); //Sirve como un intermediario entre la BD y la aplicacion.
        DataSet miDs = new DataSet(); //Es una representacion grafica de la BD en memoria.

        public Conexion()
        {
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academico.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }
        public DataSet obtenerDatos()
        {
            miDs.Clear();
            miComando.Connection = miConexion;

            miComando.CommandText = "select * from Materia";
            miAdaptador.SelectCommand = miComando;
            miAdaptador.Fill(miDs, "Materia");

            miComando.Connection = miConexion;

            miComando.CommandText = "select * from Alumno";
            miAdaptador.SelectCommand = miComando;

            return miDs;
        }



        public String mantenimientoMaterias(String[] materias)
        {
            String sql = "";
            if (materias[0] == "nuevo")
            {
                sql = "INSERT INTO Materia (codigo, materia, uv) VALUES('" + materias[1] + "', '" + materias[2] + "', '" +
                    materias[3] + "')";
            }
            else if (materias[0] == "modificar")
            {
                sql = "UPDATE Materia SET codigo='" + materias[1] + "', materia='" + materias[2] + "', uv='" + materias[3] +
                    "' WHERE idMateria='" + materias[4] + "'";
            }
            else if (materias[0] == "eliminar")
            {
                sql = "DELETE FROM Materia WHERE idMateria='" + materias[4] + "'";
            }
            return ejecutarSql(sql);
        }
        public String mantenimientoAlumnos(String[] alumnos)
        {
            String sql = "";
            if (alumnos[0] == "nuevo")
            {
                sql = "INSERT INTO alumnos (codigo, nombre, direccion, telefono) VALUES('" + alumnos[1] + "', '" + alumnos[2] + "', '" +
                    alumnos[3]+"', '"+ alumnos[4]+ "')";
            }
            else if (alumnos[0] == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + alumnos[1] + "', nombre='" + alumnos[2] + "', direccion='" + alumnos[3] +"'telefono='"+
                 alumnos[4]+   "' WHERE idAlunmo='" + alumnos[5] + "'";
            }
            else if (alumnos[0] == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno='" + alumnos[5] + "'";
            }
            return ejecutarSql(sql);
        }


        private string ejecutarSql(String sql)
        {
            try
            {
                miComando.CommandText = sql;
                miComando.Connection = miConexion;
                return miComando.ExecuteNonQuery().ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

    }


    }


    

