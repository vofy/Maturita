public class MedDekorator extends DekoratorZmrzliny {

 public MedDekorator(IZmrzlina specialniZmrzlina) {
   super(specialniZmrzlina);
 }

 public String vyrobZmrzlinu() {
   return specialniZmrzlina.vyrobZmrzlinu() + pridejMed();
 }
 
 private String pridejMed() {
   return " + sladký med";
 }
}