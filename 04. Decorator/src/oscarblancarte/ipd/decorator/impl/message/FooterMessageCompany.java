/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oscarblancarte.ipd.decorator.impl.message;

/**
 *
 * @author crist
 */
public class FooterMessageCompany {

    private String companyName;
    private String companyAddress;
    private String companyTelephone;
    private String companyEmail;
    
    public FooterMessageCompany(String companyName, String companyAddress, String companyTelephone, String companyEmail) {
        this.companyName = companyName;
        this.companyAddress = companyAddress;
        this.companyTelephone = companyTelephone;
        this.companyEmail = companyEmail;
    }
    
    public String getCompanyName() {
        return companyName;
    }

    public void setCompanyName(String companyName) {
        this.companyName = companyName;
    }

    public String getCompanyAddress() {
        return companyAddress;
    }

    public void setCompanyAddress(String companyAddress) {
        this.companyAddress = companyAddress;
    }

    public String getCompanyTelephone() {
        return companyTelephone;
    }

    public void setCompanyTelephone(String companyTelephone) {
        this.companyTelephone = companyTelephone;
    }

    public String getCompanyEmail() {
        return companyEmail;
    }

    public void setCompanyEmail(String companyEmail) {
        this.companyEmail = companyEmail;
    }
    
    @Override
    public String toString() {
        return "FooterMessage{" + "CompanyName=" + companyName + ", \nCompanyAddress=" + companyAddress + ", CompanyTelephone=" + companyTelephone + ", CompanyEmail=" + companyEmail + '}';
    }
    
}
