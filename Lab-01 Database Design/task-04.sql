CREATE OR REPLACE PROCEDURE recalculate_quest_ratings()
LANGUAGE plpgsql
AS $$
BEGIN
    UPDATE quest q
    SET average_rating = sub.avg_rating
    FROM (
        SELECT quest_id, AVG(rating)::FLOAT AS avg_rating
        FROM quest_participation
        WHERE rating IS NOT NULL
        GROUP BY quest_id
    ) sub
    WHERE q.id = sub.quest_id;
END;
