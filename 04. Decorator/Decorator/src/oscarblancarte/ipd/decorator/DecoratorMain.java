package oscarblancarte.ipd.decorator;

import oscarblancarte.ipd.decorator.impl.decorators.SOAPEnvelopMessage;
import oscarblancarte.ipd.decorator.impl.message.IMessage;
import oscarblancarte.ipd.decorator.impl.decorators.EncryptMessage;
import oscarblancarte.ipd.decorator.impl.decorators.FooterDecorator;
import oscarblancarte.ipd.decorator.impl.message.CustomerMessage;
import oscarblancarte.ipd.decorator.impl.decorators.XMLFormatterDecorate;
import oscarblancarte.ipd.decorator.impl.message.FooterMessage;

/**
 *
 * @author Oscar Javier Blancarte Iturralde
 * @see http://www.oscarblancarteblog.com
 */
public class DecoratorMain {

    public static void main(String[] args) {
        
        CustomerMessage customerMessage = new CustomerMessage(
                "Oscar Blancarte", "oscarblancarte3@gmail.com", "554433445566");
        System.out.println("Original Message ==> " + customerMessage);
        
        FooterMessage footerMessage = new FooterMessage(
                customerMessage, "Nombre", "Direccion", "Telefono", "Email");
        System.out.println("Original + Footer Message ==> " + footerMessage);


        IMessage message1 = new EncryptMessage("user", "HG58YZ3CR9123456", 
                new SOAPEnvelopMessage(
                    new XMLFormatterDecorate(
                            new FooterDecorator(footerMessage)
                      )
                  )
              ).processMessage();
        System.out.println("message1 =====================================>\n" 
                + message1.getContent() + "\n\n");
        
        IMessage message2 = new SOAPEnvelopMessage(
                new EncryptMessage("user", "HG58YZ3CR9123456",
                    new XMLFormatterDecorate(
                            new FooterDecorator(footerMessage)
                      )
                  )
              ).processMessage();
        System.out.println("message2 =====================================>\n" 
                + message2.getContent());
        
        
        IMessage message3 = new XMLFormatterDecorate(
                  new FooterDecorator(footerMessage)
              ).processMessage();
        System.out.println("message3 =====================================>\n" 
                + message3.getContent());
        
        
        
        

    }
    
}