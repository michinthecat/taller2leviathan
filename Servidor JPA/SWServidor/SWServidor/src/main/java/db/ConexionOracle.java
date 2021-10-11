/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package db;

import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;

/**
 *
 * @author jeiss
 */
public class ConexionOracle {
    private EntityManagerFactory factory;
    
    //Singleton
    private static ConexionOracle conexion = new ConexionOracle();
    
    public static ConexionOracle getConexion(){
        return conexion;
    }
    
    private ConexionOracle(){
        factory = Persistence.createEntityManagerFactory("com.mycompany_SWServidor_war_1.0-SNAPSHOTPU");
    }
    
    

    public EntityManagerFactory getFactory() {
        return factory;
    }

    public void setFactory(EntityManagerFactory factory) {
        this.factory = factory;
    }
}
