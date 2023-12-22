import React from 'react';
import { useDispatch, useSelector } from 'react-redux';
import Pagination from 'react-bootstrap/Pagination';
import { fetchPaginationData, setCurrentPage } from '../../features/product-slice';

const PaginationComponent = () => {
    const dispatch = useDispatch();
    const { currentPage, totalPages } = useSelector((state) => state.data.pagination);
    const limit = 8; // Number of items per page

    const handlePageChange = (newPage) => {
        dispatch(setCurrentPage(newPage));
        dispatch(fetchPaginationData({ page: newPage, limit }));
    };

    const renderPageNumbers = () => {
        let items = [];
        for (let number = 1; number <= totalPages; number++) {
            items.push(
                <Pagination.Item 
                    key={number} 
                    active={number === currentPage}
                    onClick={() => handlePageChange(number)}>
                    {number}
                </Pagination.Item>
            );
        }
        return items;
    };

    return (
        <Pagination>
            {currentPage > 1 && <Pagination.Prev onClick={() => handlePageChange(currentPage - 1)} />}
            {renderPageNumbers()}
            {currentPage < totalPages && <Pagination.Next onClick={() => handlePageChange(currentPage + 1)} />}
        </Pagination>
    );
};

export default PaginationComponent;
