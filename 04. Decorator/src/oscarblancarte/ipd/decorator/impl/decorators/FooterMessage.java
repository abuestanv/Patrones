/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oscarblancarte.ipd.decorator.impl.decorators;

import oscarblancarte.ipd.decorator.impl.message.FooterMessageCompany;
import oscarblancarte.ipd.decorator.impl.message.IMessage;
import oscarblancarte.ipd.decorator.impl.message.TextMessage;

/**
 *
 * @author crist
 */
public class FooterMessage extends MessageDecorator {

    private FooterMessageCompany footerCustomerMessage;
    
    public FooterMessage(IMessage message, FooterMessageCompany footerCustomerMessage){
        super(message);
        this.footerCustomerMessage = footerCustomerMessage;
    }
    
    public FooterMessageCompany getFooterCustomerMessage() {
        return footerCustomerMessage;
    }

    public void setFooterCustomerMessage(FooterMessageCompany footerCustomerMessage) {
        this.footerCustomerMessage = footerCustomerMessage;
    }

    @Override
    public IMessage processMessage() {
        message = message.processMessage();
        message = CustomFooterMessage();
        return message;
    }
    
   
   private IMessage CustomFooterMessage(){
       String customMessage = message.getContent().toString() + footerCustomerMessage.toString();
       return new TextMessage(customMessage);
   }
}
