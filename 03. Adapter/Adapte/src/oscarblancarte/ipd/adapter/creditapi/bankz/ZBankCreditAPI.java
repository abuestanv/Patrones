package oscarblancarte.ipd.adapter.creditapi.bankz;

/**
 *
 * @author ABUESTAN
 */
public class ZBankCreditAPI {
        public ZBankCreditResponse sendCreditRequest(ZBankCreditRequest request) throws Exception {
            ZBankCreditResponse response =new ZBankCreditResponse();
            if(request.getRequestAmount()<= 50000){
                response.setAproval(true);
            }else{
                response.setAproval(false);
                throw new Exception("Aprobacion rechazada zBank");
            }
        return response;
    }
}
