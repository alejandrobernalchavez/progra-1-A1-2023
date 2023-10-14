using System;

public class Class1
{
	public Class1()
	{
        string[][] tiposConversores = {
           new String[] {"Dolar","Euro","Quetzal","Lempira","Colon Salvadoreño","Cordoba","Peso Costarricense","Yenes","Libras Esterlinas","Rupia india"},//Monedas
           new String[] { "Miligramos", "Gramos","Kilogramos","Libras","Toneladas","Tonelada corta","Tonelada larga","Onza","Quintal","Stone"},//Masa
           new String[] { "Mililitro","Litro", "Metro Cubico", "Galon", "Cuarto", "Pinta", "Onza liquida","Taza","Cucharada","Cucharadita"},//Volumen
           new String[] { "Micrometro", "Milimetro", "Centimetro", "Metro","Kilometro","Milla","Milla nautica","Yarda","Pulgada","Pie"},//Longitud
           new String[] {"Bit","Byte","Kilobit","Kilobyte","Megabit","Megabyte","Gigabit","Gigabyte","Terabit","Terabyte"},//Almacenamiento
           new String[] {"Microsegundo", "Milisegundo", "Segundo","Minuto","Hora","Dia","Semana","Año","Decada","Siglo"},//Tiempo
           new String[] {"Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectarea"},//Área
        };
        double[][] unidades = {
                new double[] { 1, 0.92, 7.86, 24.66, 8.75, 36.58, 535.14, 145.47, 0.79, 83.29 }, //monedas
                new double[]{1000000000,1000000,1000,2200,1,1.1002,0.9842,35274,10,157.473},//Masa
                new double[]{1000,1,0.001,0.264172,1.05669,2.11338,33.814,4.1667,67.628,202.884},//Volumen
                new double[]{1000000, 1000, 100,1,0.001,0.00062137,0.0005399,1.09361,39.3701,3.28084},//Longitud
                new double[]{8000000,1000000,8000,1000,8,1,0.008,0.001,0.000008,0.000001},//Almacenamiento
                new double[]{ 86400000000, 86400000,86400,1440,24,1,1.0/7,1.0/365,1.0/3650,1.0/36500},//Tiempo
                new double[]{ 10.7639104, 1.431153292, 1.19599005, 1, 0.0022695, 0.000141844, 0.0001},//Área
            };
    }
}
