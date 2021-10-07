package estructural;

import java.time.LocalDateTime;

public class Pedido {
    
        private Number idPedido;
        
        private LocalDateTime fecha;
        
        private Double precioEnvio;
        
        private Double precioImpuestos;
        
        private String guia;
        
        private Number idCuentaAmazon;
        
        private Number idCourier;
        
        public Pedido() {
           
        }


        public Pedido(Number idPedido, LocalDateTime fecha, Double precioEnvio, Double precioImpuestos, String guia,
                      Number idCuentaAmazon, Number idCourier) {
            this.idPedido = idPedido;
            this.fecha = fecha;
            this.precioEnvio = precioEnvio;
            this.precioImpuestos = precioImpuestos;
            this.guia = guia;
            this.idCuentaAmazon = idCuentaAmazon;
            this.idCourier = idCourier;
        }


        public void setIdPedido(Number idPedido) {
            this.idPedido = idPedido;
        }

        public Number getIdPedido() {
            return idPedido;
        }

        public void setFecha(LocalDateTime fecha) {
            this.fecha = fecha;
        }

        public LocalDateTime getFecha() {
            return fecha;
        }

        public void setPrecioEnvio(Double precioEnvio) {
            this.precioEnvio = precioEnvio;
        }

        public Double getPrecioEnvio() {
            return precioEnvio;
        }

        public void setPrecioImpuestos(Double precioImpuestos) {
            this.precioImpuestos = precioImpuestos;
        }

        public Double getPrecioImpuestos() {
            return precioImpuestos;
        }

        public void setGuia(String guia) {
            this.guia = guia;
        }

        public String getGuia() {
            return guia;
        }

        public void setIdCuentaAmazon(Number idCuentaAmazon) {
            this.idCuentaAmazon = idCuentaAmazon;
        }

        public Number getIdCuentaAmazon() {
            return idCuentaAmazon;
        }

        public void setIdCourier(Number idCourier) {
            this.idCourier = idCourier;
        }

        public Number getIdCourier() {
            return idCourier;
        }


        @Override
        public String toString() {
            // TODO Implement this method
            return super.toString();
        }
}
