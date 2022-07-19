/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package oscarblancarte.ipd.decorator.impl.decorators;

import oscarblancarte.ipd.decorator.impl.message.IMessage;
import oscarblancarte.ipd.decorator.impl.message.TextMessage;

/**
 *
 * @author ABUESTAN
 */
public class FooterDecorator extends MessageDecorator {

    public FooterDecorator(IMessage message) {
        super(message);
    }

    @Override
    public IMessage processMessage() {
        message = message.processMessage();
        message = obtenerMessage();
        return message;
    }

    public IMessage obtenerMessage() {
        return message;
    }
    
    
}
