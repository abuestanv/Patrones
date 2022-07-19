/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oscarblancarte.ipd.decorator.impl.message;

/**
 *
 * @author ABUESTAN
 */
public class FooterMessage implements IMessage {

    private CustomerMessage customerMessage;
    private String companyName;
    private String companyAddress;
    private String companyTelephone;
    private String companyEmail;
    
    
    public FooterMessage (CustomerMessage customer, String name, String address, String phone, String email) {
        this.customerMessage = customer;
        this.companyName = name;
        this.companyAddress = address;
        this.companyTelephone = phone;
        this.companyEmail = email;
    }
    
    
    @Override
    public IMessage processMessage() {
        return this;
    }

    @Override
    public void setContent(String content) {
        throw new UnsupportedOperationException("Not supported yet.");
    }

    @Override
    public String toString() {
        return customerMessage.toString() + "\n FooterMessage{" + 
                "companyName=" + companyName + ", companyAddress=" + companyAddress + 
                ", companyTelephone=" + companyTelephone + ", companyEmail=" + companyEmail + '}';
    }

    @Override
    public String getContent() {
        return toString();
    }
    
    public String getCompanyName() { return companyName; }
    public void setCompanyName(String companyName) { this.companyName = companyName; }

    public String getCompanyAddress() { return companyAddress; }
    public void setCompanyAddress(String companyAddress) { this.companyAddress = companyAddress; }

    public String getCompanyTelephone() { return companyTelephone; }
    public void setCompanyTelephone(String companyTelephone) { this.companyTelephone = companyTelephone; }

    public String getCompanyEmail() { return companyEmail; }
    public void setCompanyEmail(String companyEmail) { this.companyEmail = companyEmail; }

    public CustomerMessage getCustomerMessage() { return customerMessage; }
    public void setCustomerMessage(CustomerMessage customerMessage) { this.customerMessage = customerMessage; }
    
    
    
    
}
