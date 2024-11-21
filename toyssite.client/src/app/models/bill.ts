export interface Bill {
    id: number;
    customerPhone: string;
    customerAddress: string;
    isDelivery: boolean;
    billNumber: number;
    ipAddress: string;
    isOpen: boolean;
}