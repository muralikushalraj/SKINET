import { IProduct } from "./Product";

export interface IPagination {
    pageSize: number;
    pageIndex: number;
    count: number;
    data: IProduct[];
}