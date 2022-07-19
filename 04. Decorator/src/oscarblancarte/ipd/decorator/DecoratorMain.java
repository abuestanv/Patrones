package oscarblancarte.ipd.decorator;

import oscarblancarte.ipd.decorator.impl.decorators.SOAPEnvelopMessage;
import oscarblancarte.ipd.decorator.impl.message.IMessage;
import oscarblancarte.ipd.decorator.impl.decorators.EncryptMessage;
import oscarblancarte.ipd.decorator.impl.decorators.FooterMessage;
import oscarblancarte.ipd.decorator.impl.message.CustomerMessage;
import oscarblancarte.ipd.decorator.impl.decorators.XMLFormatterDecorate;
import oscarblancarte.ipd.decorator.impl.message.FooterMessageCompany;

/**
 *
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
public class DecoratorMain {

    public static void main(String[] args) {
        
        CustomerMessage customerMessage = new CustomerMessage(
                "Oscar Blancarte", "oscarblancarte3@gmail.com", "554433445566");
        FooterMessageCompany footerCustomerMessage = new FooterMessageCompany("Empresa XYZ", "Paseo de los cañaris y Viracochabamba", "+593894572516", "empresaxyz@gmail.com");
        System.out.println("Original Message ==> " + customerMessage + " " + footerCustomerMessage.toString());
        
        IMessage message1 = new EncryptMessage("user", "HG58YZ3CR9123456", 
                new SOAPEnvelopMessage(
                    new XMLFormatterDecorate(new FooterMessage(customerMessage, footerCustomerMessage)))).processMessage();
        System.out.println("message1 =====================================>\n" 
                + message1.getContent() + "\n\n");
        
        IMessage message2 = new SOAPEnvelopMessage(
                new EncryptMessage("user", "HG58YZ3CR9123456",
                    new XMLFormatterDecorate(new FooterMessage(customerMessage, footerCustomerMessage)))).processMessage();
        System.out.println("message2 =====================================>\n" 
                + message2.getContent());
        
        IMessage message3 = new SOAPEnvelopMessage(
                                   new XMLFormatterDecorate(customerMessage)).processMessage();
        System.out.println("message3 =====================================>\n" 
                + message3.getContent());
    }
    
}