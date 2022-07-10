/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oscarblancarte.ipd.builder.dto;

/**
 *
 * @author ABUESTAN
 */
public class Departments {

    private String name;
    
    public Departments() {
    }

    public Departments(String name) {
        this.name = name;
    }

    
    public String getName() {
        return name;
    }
    public void setName(String name) {
        this.name = name;
    }
    
    
    @Override
    public String toString() {
        return "Departments{" + "name=" + name + "}";
    }
    
    
}
