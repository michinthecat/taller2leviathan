package dbpack;

import java.sql.*;

public class ConexionOracle {
        private Connection con;
        private String user;
        private String password;
        private Statement stmt;
        private String url;
        private String nombreBD;

        public ConexionOracle( String us, String pass){
           user = us;
           password = pass;
           nombreBD  = "xe";
           conectar();
        }

        public ConexionOracle() {
            this("proyecto","proyecto");
        }

        //Metodo para conectarce a una base de datos
        private void conectar(){
            try{

                Class.forName("oracle.jdbc.driver.OracleDriver");
            }
            catch(ClassNotFoundException e){
                System.err.println("'conectarAccess()' Error al intentar cargar Driver. "+e.getMessage());
                e.printStackTrace();
            }

            try{
                url="jdbc:oracle:thin:@localhost:1521:"+nombreBD;
                con = DriverManager.getConnection(url,user,password);

                con.setAutoCommit(true);
                System.out.println("Conexion exitosa...");
            }catch(Exception e){
                System.out.println("Error al conectarce: "+e);
            }
        }


        //Metodo que permite ejecutar una consulta y retorna un objeto ResulSet con
        //los resultados.
        public ResultSet executeQueryStatement(String cad) throws SQLException{
            ResultSet res = null;
            
                stmt = con.createStatement();
                res = stmt.executeQuery(cad);
                System.out.println("Consulta realizada...  ");
                

            return res;
        }

        //metodo que permite ejecutar una transaccion de insercion o actualizacion
        //o eliminacion
        public boolean executeUpdateStatement(String cad){
            int r = 0;
            try{
                stmt = con.createStatement();
                r = stmt.executeUpdate(cad);
                System.out.println("Actualizacion realizada...  " + r);
                //con.commit();
                stmt.close();
                return true;
            }catch(Exception ex){
                System.out.println("No se pudo efectuar la grabacion..." + ex);
                return false;
            }
        }

        //Metodo para invocar un procedimiento almacenado
        public void executeProcedure(String cadProc){
            try{

                CallableStatement proc =con.prepareCall("{ call " + cadProc + " }");
                proc.execute();
            }catch (SQLException e)
            {
                System.out.println("Problemas con la invocacion del procedimiento " + cadProc);
            }
        }


        

        //Objeto que cierra la conexion con la base de datos.
        public void closeConecction(){
            try{
                if(con != null){
                    con.close();
                }
            }catch(SQLException e){
                System.out.println("Error! " + e);
            }
        }


        public void setCon(Connection con) {
            this.con = con;
        }

        public Connection getCon() {
            return con;
        }

        public void setUser(String user) {
            this.user = user;
        }

        public String getUser() {
            return user;
        }

        public void setPassword(String password) {
            this.password = password;
        }

        public String getPassword() {
            return password;
        }

        public void setStmt(Statement stmt) {
            this.stmt = stmt;
        }

        public Statement getStmt() {
            return stmt;
        }

        public void setUrl(String url) {
            this.url = url;
        }

        public String getUrl() {
            return url;
        }

        public void setNombreBD(String nombreBD) {
            this.nombreBD = nombreBD;
        }

        public String getNombreBD() {
            return nombreBD;
        }}