package oscarblancarte.ipd.adapter.impl;

import oscarblancarte.ipd.adapter.creditapi.bankz.ZBankCreditAPI;
import oscarblancarte.ipd.adapter.creditapi.bankz.ZBankCreditRequest;
import oscarblancarte.ipd.adapter.creditapi.bankz.ZBankCreditResponse;

/**
 *
 * @author ABUESTAN
 */
public class ZBankCreditAdapter implements IBankAdapter {

    @Override
    public BankCreditResponse sendCreditRequest(BankCreditRequest request) {
        ZBankCreditRequest zrequest = new ZBankCreditRequest();
        zrequest.setCustomerName(request.getCustomer());
        zrequest.setRequestAmount(request.getAmount());
        
        ZBankCreditAPI api = new ZBankCreditAPI();
        ZBankCreditResponse zresponse = new ZBankCreditResponse();
        try {
            zresponse = api.sendCreditRequest(zrequest);
        } catch(Exception ex) {
            ex.printStackTrace();
            zresponse.setAproval(false);
        }            

        BankCreditResponse response = new BankCreditResponse();
        response.setApproved(zresponse.isAproval());
        return response;
    }
    
}
